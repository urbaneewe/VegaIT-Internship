const path = require('path');
const ESLintPlugin = require('eslint-webpack-plugin');

const eslintOptions = {
	fix: true,
	files: './js/**/*.js'
};

const mode = process.argv.includes('webpackProd') ? "production" : "development";

module.exports = {
	entry: {
		global: './js/global.js'
	},
	output: {
		path: path.join(__dirname, './dist/'),
		filename: '[name].js'
	},
	mode,
	resolve: {
		alias: {
			core: path.join(__dirname, 'core'),
		},
	},
	module: {
		rules: [
			{
				test: path.join(__dirname),
				loader: 'babel-loader',
			},
		],
	},
	optimization: {
		usedExports: true
	},
	plugins: [
		new ESLintPlugin(eslintOptions),
	],
};
