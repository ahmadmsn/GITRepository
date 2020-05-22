'use strict';

var utils = require('../utils/writer.js');
var Default = require('../service/DefaultService');

module.exports.moviePUT = function moviePUT (req, res, next) {
  var movie = req.swagger.params['movie'].value;
  Default.moviePUT(movie)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

module.exports.moviesGET = function moviesGET (req, res, next) {
  Default.moviesGET()
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};
