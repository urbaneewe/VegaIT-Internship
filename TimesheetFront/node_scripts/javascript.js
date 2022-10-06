const webpack = require('webpack');
const webpackConfig = require('../webpack.config');

const runWebpack = () => {
	return new Promise((res) => {
		const compiler = webpack(webpackConfig);

		const config = {
			colors: true,
			performance: false,
			timings: false,
			excludeAssets: true,
			assets: false,
			entrypoints: false,
			modules: false,
			hash: false,
			version: false,
			builtAt: false,
		};

		compiler.run((_, stats) => {
			if (stats.hasErrors()) {
				console.log(stats.toString(config));
			} else if (stats.hasWarnings()) {
				console.log(stats.toString(config));
			}

			res();
		});
	});
};

runWebpack();

module.exports = {
	webpack: runWebpack
};
