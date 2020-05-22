'use strict';


/**
 * Add Movie to the library
 *
 * movie Movie Movie you want to update
 * returns Message
 **/
exports.moviePUT = function(movie) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "cast" : "cast",
  "code" : 0,
  "year" : 6,
  "director" : "director",
  "description" : "description"
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


/**
 * Returns all the movie from the list
 *
 * returns List
 **/
exports.moviesGET = function() {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = [ {
  "year" : 6,
  "director" : "director",
  "name" : "name",
  "id" : 0
}, {
  "year" : 6,
  "director" : "director",
  "name" : "name",
  "id" : 0
} ];
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}

