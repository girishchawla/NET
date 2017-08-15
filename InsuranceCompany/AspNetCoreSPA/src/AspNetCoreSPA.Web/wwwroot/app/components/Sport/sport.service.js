﻿(function () {
    'use strict';
    angular
        .module('sportModule')
        .factory('sport', sport);

    sport.$inject = ['$resource'];

    function sport($resource) {
        var resourceUrl = 'https://localhost:8443/sport/getAll';

        return $resource(resourceUrl, {}, {
            'query': { method: 'GET', isArray: true },
            'get': {
                method: 'GET',
                transformResponse: function (data) {
                    if (data) {
                        data = angular.fromJson(data);
                    }
                    return data;
                },
                headers: { 'Access-Control-Allow-Origin': '*' }
            },
            'update': { method: 'PUT' },
            'save': { method: 'POST', headers: { 'Access-Control-Allow-Origin': '*' } }
        });
    }
})();
