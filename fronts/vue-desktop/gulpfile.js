var gulp = require('gulp')
var sourcemaps = require('gulp-sourcemaps')
var babel = require('gulp-babel')
var del = require('del')
// var concat = require('gulp-concat')

gulp.task('engine', function () {
  return gulp.src('src/engine.js')
    .pipe(sourcemaps.init())
    .pipe(babel())
    .pipe(sourcemaps.write('.'))
    .pipe(gulp.dest('dist/engine'))
})

gulp.task('del:views', function () {
  return del(['../ZeroRoo.Docker/bin/x64/Debug/views'], { force: true })
})

gulp.task('copy:dist', function () {
  return gulp.src('dist/**/*')
        .pipe(gulp.dest('../ZeroRoo.Docker/bin/x64/Debug/views'))
})

gulp.task('clean:dist', function () {
  return del(['dist/*'], { force: true })
})

gulp.task('watch:dist', function () {
  gulp.watch('dist/*', ['copy:dist'])
  gulp.watch('src/engine.js', ['engine'])
})

gulp.task('default', ['watch:dist'])
