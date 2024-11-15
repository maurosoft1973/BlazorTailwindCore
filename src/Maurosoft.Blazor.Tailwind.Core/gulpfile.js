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
    console.log(logSymbols.info, "Generate Css");
    const tailwindcss = require("tailwindcss");
    return src(`${options.paths.assets.css}/style.scss`)
        .pipe(sass().on("error", sass.logError))
        .pipe(
            postcss([
                tailwindcss(options.config.tailwindjs)
            ])
        )
        .pipe(dest(options.paths.wwwroot.css));
}

function TaskJs() {
    console.log(logSymbols.info, "Copy Js");
    return src(`${options.paths.assets.js}/**/*`).pipe(
        dest(options.paths.wwwroot.js)
    );
}

exports.build = series(TaskCleanCss, TaskCleanJs, TaskCss, TaskJs);
exports.clean = series(TaskCleanCss, TaskCleanJs);
exports.css = series(TaskCss);
exports.js = series(TaskJs);
