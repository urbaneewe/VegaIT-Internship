const watch = require('node-watch');
const { webpack } = require('./javascript');
const { runSCSS } = require('./scss');

watch('scss', { recursive: true }, runSCSS);
watch('js', { recursive: true }, webpack);
