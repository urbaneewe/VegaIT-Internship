const fs = require('fs');
const postcss = require('postcss');
const sass = require('sass');
const stylelint = require('stylelint');
const autoprefixer = require('autoprefixer');
const path = require('path');

const scss = path.join('scss');

const makeFolderIfMissing = (inputPath) => {
	if (!fs.existsSync(inputPath)) {
		fs.mkdirSync(inputPath, { recursive: true });
	}
};

const compileSCSS = () => {
	const outputFolder = path.join('dist');
	const output = path.join(outputFolder, 'style.css');

	return new Promise((res) => {
		makeFolderIfMissing(outputFolder);

		sass.render({
			file: path.join(scss, 'style.scss'),
			outFile: output,
			sourceMap: true,
			sourceMapEmbed: true,
			outputStyle: 'expanded',
		}, (err, result) => {
			if (!err) {
				postcss([autoprefixer]).process(result.css, { from: undefined, to: path.join('css/style3.css') }).then((result) => {
					fs.writeFile(output, result.css, (err) => {
						if (err) {
							console.log(err);
						}
						res();
					});
				});
			} else {
				const filePath = path.resolve(err.file);
				const trimmedPath = filePath.replace(path.resolve(scss), 'scss');

				console.log(`\nmessage: ${colors.red(err.message)} \nfile: ${trimmedPath} \nline: ${err.line} \ncolumn: ${err.column}\n`);
				res();
			}
		});
	});

};

const lintSCSS = () => {
	return new Promise((res) => {

		stylelint.lint({
			configFile: '.stylelintrc.json',
			files: 'scss/**/*.scss',
			fix: true
		})
			.then((data) => {
				const output = stylelint.formatters.string(data.results);

				if (output) console.log(output);
				res();
			})
			.catch((err) => {
				console.error(err.stack);
				res(err.stack);
			});
	});
};

const runSCSS = async() => {
	await lintSCSS();
	await compileSCSS();
};

runSCSS();

module.exports = {
  runSCSS
}