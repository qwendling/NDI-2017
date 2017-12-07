var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res) {
  res.render('index', { title: 'Express' });
});

router.get('/konami', function(req, res) {
  res.render('konami', { title: 'Konami' });
});

module.exports = router;
