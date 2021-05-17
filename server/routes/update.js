const router = require('express').Router();
const updateControllers = require('../controllers/updateController');

router.get('/test',(req,res) => {
    res.send('route page update');
})

router.post('/deposita/motorinoelettrico',updateControllers.motorinoelettrico);
router.post('/deposita/auto',updateControllers.auto);
router.post('/deposita/monopattinoelettrico',updateControllers.monopattino);
router.post('/deposita/bici',updateControllers.bici);
router.post('/deposita/ebike',updateControllers.ebike);

router.post('/noleggia',updateControllers.noleggia);
router.post('/segnala',updateControllers.segnala);

module.exports = router;

