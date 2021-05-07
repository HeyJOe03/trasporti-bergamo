const router = require('express').Router();
const searchControllers = require('../controllers/searchControllers');

router.get('/test',(req,res) => {
    res.send('route page')});

    
router.post('/motorinoelettrico', searchControllers.motorinoelettrico);

router.post('/auto',searchControllers.auto);

router.post('/monopattinoelettrico',searchControllers.monopattino                                      );

router.post('/bici',searchControllers.bici);

router.post('/ebike',searchControllers.ebike);

router.post('/utente',searchControllers.utente);

module.exports = router;