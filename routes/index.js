var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res) {
  res.render('index', { title: 'Who\'SAM' });
});

router.get('/konami', function(req, res) {
  res.render('konami', { title: 'Konami' });
});

router.get('/application', function(req, res) {
  res.render('application', { title: 'Who\'SAM' });
});

router.get('/avant24',function(req,res) {
  res.render('avant24');
});

module.exports = router;
