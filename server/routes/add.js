const addControllers = require('../controllers/addControllers');

const router = require('express').Router();


router.get('/test',(req,res) => {
    res.send('route page');
})

router.post('/motorinoelettrico', addControllers.motorinoelettrico);

router.post('/auto',addControllers.auto);

router.post('/monopattinoelettrico',addControllers.monopattinoelettrico);

router.post('/bici',addControllers.bici);

router.post('/ebike',addControllers.ebike);

router.post('/utente',addControllers.utente);


module.exports = router;