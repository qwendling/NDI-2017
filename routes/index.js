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

  router.get('/avant1',function(req,res) {
    res.render('avant1');
});

router.get('/avant2',function(req,res) {
  res.render('avant2');
});

router.get('/avant3',function(req,res) {
  res.render('avant3');
});

router.get('/avant4',function(req,res) {
  res.render('avant4');
});

router.get('/avant5',function(req,res) {
  res.render('avant5');
});

router.get('/avant6',function(req,res) {
  res.render('avant6');
});

router.get('/avant7',function(req,res) {
  res.render('avant7');
});

router.get('/avant8',function(req,res) {
  res.render('avant8');
});

router.get('/avant9',function(req,res) {
  res.render('avant9');
});
router.get('/avant10',function(req,res) {
  res.render('avant10');
});
router.get('/avant11',function(req,res) {
  res.render('avant11');
});
router.get('/avant12',function(req,res) {
  res.render('avant12');
});
router.get('/avant13',function(req,res) {
  res.render('avant13');
});
router.get('/avant14',function(req,res) {
  res.render('avant14');
});

router.get('/avant15',function(req,res) {
  res.render('avant15');
});

router.get('/avant16',function(req,res) {
  res.render('avant16');
});
router.get('/avant17',function(req,res) {
  res.render('avant17');
});
router.get('/avant18',function(req,res) {
  res.render('avant18');
});
router.get('/avant19',function(req,res) {
  res.render('avant19');
});
router.get('/avant20',function(req,res) {
  res.render('avant20');
});
router.get('/avant21',function(req,res) {
  res.render('avant21');
});
router.get('/avant22',function(req,res) {
  res.render('avant22');
});
router.get('/avant23',function(req,res) {
  res.render('avant23');
});





module.exports = router;
