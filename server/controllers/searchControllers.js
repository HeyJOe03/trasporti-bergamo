const DB = require('../db/dbconnection');
const searchSQL = require('../db/SQL/search');

const badQuery = {'error':'bad query'};
const noElements = {'error':'no elements'};

module.exports.motorinoelettrico = (req,res) => {
    //console.log(searchSQL.motorinoelettrico({}));
    let id = {};
    if(req.body.ID === undefined) id = {};
    else id = {ID: req.body.ID};
    DB.query(searchSQL.motorinoelettrico(id), (e,result) => {
        if(e) res.json(badQuery);
        else if(!result[0]) res.json(noElements);
        else{
            res.json(result);
        }
    });  //empty object = all
}
module.exports.auto = (req,res) => {
    //console.log(searchSQL.motorinoelettrico({}));
    let id = {};
    if(req.body.ID === undefined) id = {};
    else id = {ID: req.body.ID};
    DB.query(searchSQL.auto(id), (e,result) => {
        if(e) res.json(badQuery);
        else if(!result[0]) res.json(noElements);
        else{
            res.json(result);
        }
    });  //empty object = all
}
module.exports.monopattino = (req,res) => {
    let id = {};
    if(req.body.ID === undefined) id = {};
    else id = {ID: req.body.ID};
    DB.query(searchSQL.monopattino(id), (e,result) => {
        if(e) res.json(badQuery);
        else if(!result[0]) res.json(noElements);
        else{
            res.json(result);
        }
    });  //empty object = all
}
module.exports.bici = (req,res) => {
    //console.log(searchSQL.bici({}));
    let id = {};
    if(req.body.ID === undefined) id = {};
    else id = {ID: req.body.ID};
    DB.query(searchSQL.motorinoelettrico(id), (e,result) => {
        if(e) res.json(badQuery);
        else if(!result[0]) res.json(noElements);
        else{
            res.json(result);
        }
    });  //empty object = all
}
module.exports.ebike = (req,res) => {
    //console.log(searchSQL.motorinoelettrico({}));
    let id = {};
    if(req.body.ID === undefined) id = {};
    else id = {ID: req.body.ID};
    DB.query(searchSQL.motorinoelettrico(id), (e,result) => {
        if(e) res.json(badQuery);
        else if(!result[0]) res.json(noElements);
        else{
            res.json(result);
        }
    });  //empty object = all
}
module.exports.utente = (req,res) => {
    
    //console.log(req.body);
    let cf = {};
    if(req.body.CF === undefined) cf = {};
    else cf = {CF: req.body.CF};

    //console.log(searchSQL.utente(cf));
    DB.query(searchSQL.utente(cf), (e,result) => {
        if(e) res.json(badQuery);
        else if(!result[0]) res.json(noElements);
        else{
            res.json(result);
        }
    });  //empty object = all
}