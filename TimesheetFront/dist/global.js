/*
 * ATTENTION: The "eval" devtool has been used (maybe by default in mode: "development").
 * This devtool is neither made for production nor for readable output files.
 * It uses "eval()" calls to create a separate source file in the browser devtools.
 * If you are trying to read the output file, select a different devtool (https://webpack.js.org/configuration/devtool/)
 * or disable the default devtool with "devtool: false".
 * If you are looking for production-ready output files, see mode: "production" (https://webpack.js.org/configuration/mode/).
 */
/******/ (() => { // webpackBootstrap
/******/ 	var __webpack_modules__ = ({

/***/ "./js/global.js":
/*!**********************!*\
  !*** ./js/global.js ***!
  \**********************/
/***/ (() => {

eval("//Navigation Hamburger menu\nconst link = document.getElementById('navigation__link');\nconst burger = document.getElementById('navigation__text');\nconst ul = document.querySelector('.navigation__menu');\nlink.addEventListener('click', e => {\n  e.preventDefault();\n  burger.classList.toggle('nav-toggle-open');\n  ul.classList.toggle('nav-toggle-open');\n}); //accordion\n\nconst $accordionTriggers = $('.accordion__intro');\n$accordionTriggers.on('click', function () {\n  const $this = $(this);\n  const $parent = $this.parents('.accordion');\n  const $content = $parent.find('.accordion__content');\n  $accordionTriggers.each(function () {\n    if (this === $this[0]) {\n      $content.stop().slideToggle();\n    } else {\n      $(this).parents('.accordion').find('.accordion__content').stop().slideUp();\n    }\n  });\n}); //modal popup\n\nconst modalBtn = document.querySelector('.btn-modal');\nconst modalBg = document.querySelector('.modal');\nconst close = document.querySelector('.modal__close');\n\nif (modalBg !== null) {\n  modalBtn.addEventListener('click', () => {\n    modalBg.classList.add('modal--show');\n  });\n  close.addEventListener('click', () => {\n    modalBg.classList.remove('modal--show');\n  });\n  window.addEventListener('keydown', e => {\n    if (e.key === 'Escape') {\n      modalBg.classList.remove('modal--show');\n    }\n  });\n}\n\n//# sourceURL=webpack://timesheet.v2/./js/global.js?");

/***/ })

/******/ 	});
/************************************************************************/
/******/ 	
/******/ 	// startup
/******/ 	// Load entry module and return exports
/******/ 	// This entry module can't be inlined because the eval devtool is used.
/******/ 	var __webpack_exports__ = {};
/******/ 	__webpack_modules__["./js/global.js"]();
/******/ 	
/******/ })()
;