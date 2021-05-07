const router = require('express').Router();


router.get('/test',(req,res) => {
    res.send('route page');
})


module.exports = router;