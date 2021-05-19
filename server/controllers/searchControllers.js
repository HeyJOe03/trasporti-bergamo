const DB = require('../db/dbconnection');
const searchSQL = require('../db/SQL/search');

const badQuery = {'error':'bad query'};
const noElements = {'error':'no elements'};

module.exports.motorinoelettrico = (req,res) => {
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
    let id = {};
    if(req.body.ID === undefined) id = {};
    else id = {ID: req.body.ID};
    DB.query(searchSQL.bici(id), (e,result) => {
        if(e) res.json(badQuery);
        else if(!result[0]) res.json(noElements);
        else{
            res.json(result);
        }
    });  //empty object = all
}
module.exports.ebike = (req,res) => {
    let id = {};
    if(req.body.ID === undefined) id = {};
    else id = {ID: req.body.ID};
    DB.query(searchSQL.ebike(id), (e,result) => {
        if(e) res.json(badQuery);
        else if(!result[0]) res.json(noElements);
        else{
            res.json(result);
        }
    });  //empty object = all
}
module.exports.utente = (req,res) => {
    let cf = {};
    if(req.body.CF === undefined) cf = {};
    else cf = {CF: req.body.CF};

    DB.query(searchSQL.utente(cf), (e,result) => {
        if(e) res.json(badQuery);
        else if(!result[0]) res.json(noElements);
        else{
            res.json(result);
        }
    });  //empty object = all
}