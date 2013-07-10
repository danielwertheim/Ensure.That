#--------------------------------------
# Dependencies
#--------------------------------------
require 'albacore'
#--------------------------------------
# Debug
#--------------------------------------
#ENV.each {|key, value| puts "#{key} = #{value}" }
#--------------------------------------
# Environment vars
#--------------------------------------
@env_solutionname = 'Ensure.That'
@env_solutionfolderpath = "../src"

@env_projectnameCore = 'EnsureThat'

@env_buildfolderpath = 'build'
@env_assversion = "1.0.0"
@env_version = "#{@env_assversion}"
@env_buildversion = @env_version + (ENV['env_buildnumber'].to_s.empty? ? "" : ".#{ENV['env_buildnumber'].to_s}")
@env_buildconfigname = ENV['env_buildconfigname'].to_s.empty? ? "Release" : ENV['env_buildconfigname'].to_s

buildNameSuffix = "-v#{@env_buildversion}-#{@env_buildconfigname}"
@env_buildnameCore = "#{@env_projectnameCore}#{buildNameSuffix}"
#--------------------------------------
# Reusable vars
#--------------------------------------
coreOutputPath = "#{@env_buildfolderpath}/#{@env_projectnameCore}"
sharedAssemblyInfoPath = "#{@env_solutionfolderpath}/SharedAssemblyInfo.cs"
#--------------------------------------
# Albacore flow controlling tasks
#--------------------------------------
task :ci => [:cleanIt, :installNuGets, :versionIt, :buildIt, :copyIt, :testIt, :zipIt, :packIt]

task :local => [:cleanIt, :versionIt, :buildIt, :copyIt, :testIt, :zipIt, :packIt]
#--------------------------------------
task :copyIt => [:copyCore]

task :testIt => [:unittests]

task :zipIt => [:zipCore]

task :packIt => [:packCore, :packCoreAsSource]
#--------------------------------------
# Albacore tasks
#--------------------------------------
task :cleanIt do
	FileUtils.rm_rf(@env_buildfolderpath)
	FileUtils.mkdir_p(@env_buildfolderpath)
end

task :installNuGets do
	FileList["#{@env_solutionfolderpath}/**/packages.config"].each { |filepath|
		sh "NuGet.exe i #{filepath} -o #{@env_solutionfolderpath}/packages"
	}
end

assemblyinfo :versionIt do |asm|
    asm.input_file = sharedAssemblyInfoPath
    asm.output_file = sharedAssemblyInfoPath
    asm.version = "#{@env_assversion}.*"
    asm.file_version = @env_buildversion
end

assemblyinfo :signIt do |asm|
    asm.input_file = sharedAssemblyInfoPath
    asm.output_file = sharedAssemblyInfoPath
    asm.custom_attributes :AssemblyKeyFileAttribute => "..\\..\\#{@env_projectnameCore}.snk"
end

msbuild :buildIt do |msb|
    msb.properties :configuration => @env_buildconfigname
    msb.targets :Clean, :Build
    msb.solution = "#{@env_solutionfolderpath}/#{@env_solutionname}.sln"
end

def copyProject(projectName, v, outputPath)
    outputPath = "#{outputPath}#{v}"
    FileUtils.mkdir_p(outputPath)
    FileUtils.cp_r(FileList["#{@env_solutionfolderpath}/Projects/#{projectName}#{v}/bin/#{@env_buildconfigname}/**"], outputPath)
end

task :copyCore do
	copyProject(@env_projectnameCore, '', coreOutputPath)
end

nunit :unittests do |nunit|
    nunit.command = "nunit-console.exe"
    nunit.options "/framework=v4.0.30319","/xml=#{@env_buildfolderpath}/NUnit-Report-#{@env_solutionname}-UnitTests.xml"
    nunit.assemblies FileList["#{@env_solutionfolderpath}/Tests/#{@env_projectnameCore}.**UnitTests/bin/#{@env_buildconfigname}/#{@env_projectnameCore}.**UnitTests.dll"]
end

zip :zipCore do |zip|
	zip.directories_to_zip coreOutputPath
	zip.output_file = "#{@env_projectnameCore}-v#{@env_version}.zip"
	zip.output_path = @env_buildfolderpath
end

def packProject(cmd, projectname, basepath)
    cmd.command = "NuGet.exe"
    cmd.parameters = "pack #{projectname}.nuspec -version #{@env_version} -basepath #{basepath} -outputdirectory #{@env_buildfolderpath}"
end

exec :packCore do |cmd|
    packProject(cmd, @env_solutionname, @env_buildfolderpath)
end

exec :packCoreAsSource do |cmd|
    packProject(cmd, "#{@env_solutionname}.Source", @env_solutionfolderpath)
end