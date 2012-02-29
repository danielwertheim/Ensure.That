task :default => [:installNuGetPackages]

task :installNuGetPackages do
	FileList["Source/**/packages.config"].each { |filepath|
		sh "NuGet.exe i #{filepath} -o Source/Packages"
	}
end

task :updateNuGetPackages do
	FileList["Source/**/packages.config"].each { |filepath|
		sh "NuGet.exe update #{filepath}"
	}
end