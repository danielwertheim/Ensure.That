var gulp = require('gulp'),
    //debug = require('gulp-debug'),
    flatten = require('gulp-flatten'),
    shell = require('gulp-shell'),
    del = require('del'),
    msbuild = require('gulp-msbuild'),
    assemblyInfo = require('gulp-dotnet-assembly-info'),
    argv = require('yargs').argv,
    sequence = require('run-sequence');

var config = {
  slnname: 'Ensure.That',
  src: './../src/',
  build: {
    outdir: './build/',
    version: '3.0.0',
    revision: argv.buildrevision || '*',
    profile: argv.buildprofile || 'Release'
  }
};

gulp.task('default', function (cb) {
  sequence(
    ['clean', 'assemblyinfo'],
    'build', 'copy', 'unit-test', cb);
});

gulp.task('ci', function (cb) {
  sequence(
    ['init-tools', 'clean', 'assemblyinfo', 'nuget-restore'],
    'build', 'copy', 'unit-test', 'nuget-pack', cb);
});

gulp.task('init-tools', shell.task([
  'nuget restore ./tools/packages.config -o ./tools/']
));

gulp.task('nuget-restore', function () {
  return gulp.src(config.src + '*.sln', { read: false })
    .pipe(shell('nuget restore <%= file.path %>'));
});

gulp.task('clean', function(cb) {
  del(config.build.outdir, cb);
});

gulp.task('assemblyinfo', function() {
  return gulp
    .src(config.src + 'SharedAssemblyInfo.cs')
    .pipe(assemblyInfo({
      version: config.build.version + '.' + config.build.revision,
    }))
    .pipe(gulp.dest(config.src));
});

gulp.task('build', function() {
  return gulp.src(config.src + '*.sln')
    .pipe(msbuild({
      toolsVersion: 14.0,
      configuration: config.build.profile,
      targets: ['Clean', 'Build'],
      errorOnFail: true,
      stdout: true,
      verbosity: 'minimal'
    }));
});

gulp.task('copy', function() {
  return gulp.src(config.src + 'projects/**/bin/' + config.build.profile + '/*.{dll,XML}')
    .pipe(flatten())
    .pipe(gulp.dest(config.build.outdir));
});

gulp.task('unit-test', function () {
  return gulp.src(config.src + 'tests/**/bin/' + config.build.profile + '/*.UnitTests.dll')
    .pipe(shell('xunit.console.clr4.exe <%= file.path %> /silent /noshadow', { cwd: './tools/xunit.runners.1.9.2/tools/' }));
});

gulp.task('nuget-pack', shell.task([
  'nuget pack ./' + config.slnname + '.nuspec -version ' + config.build.version + ' -basepath ' + config.build.outdir + ' -o ' + config.build.outdir,
  'nuget pack ./' + config.slnname + '.Source.nuspec -version ' + config.build.version + ' -basepath ' + config.src + ' -o ' + config.build.outdir,]
));