const router = require('express').Router();
const updateControllers = require('../controllers/updateController');


router.get('/test',(req,res) => {
    res.send('route page');
})


router.post('/motorinoelettrico',updateControllers.motorinoelettrico);
router.post('/auto',updateControllers.auto);
router.post('/monopattinoelettrico',updateControllers.monopattino);
router.post('/bici',updateControllers.bici);
router.post('/ebike',updateControllers.ebike);

module.exports = router;

