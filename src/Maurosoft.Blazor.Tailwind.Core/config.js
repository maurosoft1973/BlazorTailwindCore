const config = {
    tailwindjs: './tailwind.config.js',
};

const paths = {
    root: './',
    dist: './dist',
    node: './node_modules',
    assets: {
        css: './Assets/Css',
        js: './Assets/Js'
    },
    wwwroot: {
        css: './wwwroot/css',
        js: './wwwroot/js'
    }
};

module.exports = {
    config,
    paths
};
