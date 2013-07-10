task :default => [:installNuGetPackages]

task :installNuGetPackages do
	FileList["src/**/packages.config"].each { |filepath|
		sh "NuGet.exe i #{filepath} -o src/packages"
	}
end

task :updateNuGetPackages do
	FileList["src/**/packages.config"].each { |filepath|
		sh "NuGet.exe update #{filepath}"
	}
end