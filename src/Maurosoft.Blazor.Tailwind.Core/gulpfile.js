const options = require("./config"); //paths and other options from config.js
const { src, dest, watch, series, parallel } = require("gulp");
const clean = require("gulp-clean"); //For Cleaning build/dist for fresh export
const sass = require("gulp-sass")(require("sass")); //For Compiling SASS files
const postcss = require("gulp-postcss"); //For Compiling tailwind utilities with tailwind config
const logSymbols = require("log-symbols"); //For Symbolic Console logs :) :P

function TaskCleanCss() {
    console.log(logSymbols.info, "Cleaning css build folder for fresh start");
    return src(options.paths.wwwroot.css, { read: false, allowEmpty: true }).pipe(
        clean()
    );
}

function TaskCleanJs() {
    console.log(logSymbols.info, "Cleaning js build folder for fresh start");
    return src(options.paths.wwwroot.js, { read: false, allowEmpty: true }).pipe(
        clean()
    );
}

function TaskCss() {
    console.log(logSymbols.info, "Generate Full Css - Minified");
    const tailwindcss = require("tailwindcss");
    const cleanCSS = require('gulp-clean-css');
    return src(`${options.paths.assets.css}/style.scss`)
        .pipe(sass().on("error", sass.logError))
        .pipe(
            postcss([
                tailwindcss(options.config.tailwindjs)
            ])
        )
        .pipe(cleanCSS({ debug: true }, (details) => {
            console.log(`${details.name}: ${details.stats.originalSize}`);
            console.log(`${details.name}: ${details.stats.minifiedSize}`);
        }))
        .pipe(dest(options.paths.wwwroot.css));
}

function TaskCssColor() {
    console.log(logSymbols.info, "Generate Css Background and Text Color - Minified");
    const tailwindcss = require("tailwindcss");
    const cleanCSS = require('gulp-clean-css');
    return src(`${options.paths.assets.css}/color.scss`)
        .pipe(sass().on("error", sass.logError))
        .pipe(
            postcss([
                tailwindcss(options.config.tailwindjscolor)
            ])
        )
        .pipe(cleanCSS({ debug: true }, (details) => {
            console.log(`${details.name}: ${details.stats.originalSize}`);
            console.log(`${details.name}: ${details.stats.minifiedSize}`);
        }))
        .pipe(dest(options.paths.wwwroot.css));
}

function TaskJs() {
    console.log(logSymbols.info, "Copy Js");
    return src(`${options.paths.assets.js}/**/*`).pipe(
        dest(options.paths.wwwroot.js)
    );
}

exports.build = series(TaskCleanCss, TaskCleanJs, TaskCss, TaskCssColor, TaskJs);
exports.clean = series(TaskCleanCss, TaskCleanJs);
exports.css = series(TaskCss);
exports.csscolor = series(TaskCssColor);
exports.js = series(TaskJs);
