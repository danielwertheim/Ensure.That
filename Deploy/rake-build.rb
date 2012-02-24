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
@env_solutionfolderpath = "../Source"

@env_projectnameEnsureThat = 'EnsureThat'

@env_buildfolderpath = 'build'
@env_version = "0.6.0"
@env_buildversion = @env_version + (ENV['env_buildnumber'].to_s.empty? ? "" : ".#{ENV['env_buildnumber'].to_s}")
@env_buildconfigname = ENV['env_buildconfigname'].to_s.empty? ? "Release" : ENV['env_buildconfigname'].to_s
@env_buildname = "#{@env_solutionname}-v#{@env_buildversion}-#{@env_buildconfigname}"
#--------------------------------------
# Reusable vars
#--------------------------------------
ensureThatOutputPath = "#{@env_buildfolderpath}/#{@env_projectnameEnsureThat}"
#--------------------------------------
# Albacore flow controlling tasks
#--------------------------------------
task :ci => [:buildIt, :copyEnsureThat, :testIt, :zipIt, :packIt]

task :local => [:buildIt, :copyEnsureThat, :testIt, :zipIt, :packIt]
#--------------------------------------
task :testIt => [:unittests]

task :zipIt => [:zipEnsureThat]

task :packIt => [:packEnsureThatNuGet, :packEnsureThatSourceNuGet]
#--------------------------------------
# Albacore tasks
#--------------------------------------
assemblyinfo :versionIt do |asm|
	sharedAssemblyInfoPath = "#{@env_solutionfolderpath}/SharedAssemblyInfo.cs"

	asm.input_file = sharedAssemblyInfoPath
	asm.output_file = sharedAssemblyInfoPath
	asm.version = @env_version
	asm.file_version = @env_buildversion  
end

task :ensureCleanBuildFolder do
	FileUtils.rm_rf(@env_buildfolderpath)
	FileUtils.mkdir_p(@env_buildfolderpath)
end

msbuild :buildIt => [:ensureCleanBuildFolder, :versionIt] do |msb|
	msb.properties :configuration => @env_buildconfigname
	msb.targets :Clean, :Build
	msb.solution = "#{@env_solutionfolderpath}/#{@env_solutionname}.sln"
end

task :copyEnsureThat do
	FileUtils.mkdir_p(ensureThatOutputPath)
	FileUtils.cp_r(FileList["#{@env_solutionfolderpath}/Projects/#{@env_projectnameEnsureThat}/bin/#{@env_buildconfigname}/**"], ensureThatOutputPath)
end

nunit :unittests do |nunit|
	nunit.command = "#{@env_solutionfolderpath}/packages/NUnit.2.5.10.11092/tools/nunit-console.exe"
	nunit.options "/framework=v4.0.30319","/xml=#{@env_buildfolderpath}/NUnit-Report-#{@env_projectnameEnsureThat}-UnitTests.xml"
	nunit.assemblies FileList["#{@env_solutionfolderpath}/Tests/#{@env_projectnameEnsureThat}.**UnitTests/bin/#{@env_buildconfigname}/#{@env_projectnameEnsureThat}.**UnitTests.dll"]
end

zip :zipEnsureThat do |zip|
	zip.directories_to_zip ensureThatOutputPath
	zip.output_file = "#{@env_buildname}.zip"
	zip.output_path = @env_buildfolderpath
end

exec :packEnsureThatNuGet do |cmd|
	cmd.command = "NuGet.exe"
	cmd.parameters = "pack #{@env_solutionname}.nuspec -version #{@env_version} -basepath #{ensureThatOutputPath} -outputdirectory #{@env_buildfolderpath}"
end

exec :packEnsureThatSourceNuGet do |cmd|
  cmd.command = "NuGet.exe"
  cmd.parameters = "pack #{@env_solutionname}.Source.nuspec -version #{@env_version} -basepath #{@env_solutionfolderpath} -outputdirectory #{@env_buildfolderpath}"
end