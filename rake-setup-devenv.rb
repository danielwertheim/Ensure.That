require 'albacore'
#--------------------------------------
task :default => [:installNuGetPackages]
#--------------------------------------
desc "Install missing NuGet packages."
exec :installNuGetPackages do |cmd|
  FileList["Solution/**/packages.config"].each { |filepath|
    cmd.command = "NuGet.exe"
    cmd.parameters = "i #{filepath} -o Solution/packages"
  }
end