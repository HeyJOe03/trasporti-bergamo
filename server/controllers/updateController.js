const DB = require('../db/dbconnection');
const updateSQL = require('../db/SQL/update');

const badQuery = {'error':'bad query'};
const noElements = {'error':'no elements'};
const missingFields = {'error':'missing fields'};

module.exports.motorinoelettrico = (req,res) => {
    if(checkVeicoliFields(req.body) && req.body.livelloBatteria !== undefined){
        res.json(updateSQL.motorinoelettrico(req.body));
    }
    else res.json(missingFields);
}
module.exports.auto = (req,res) => {
    if(checkVeicoliFields(req.body) && req.body.livelloBatteria !== undefined){
        res.json(updateSQL.auto(req.body));
    }
    else res.json(missingFields);
}
module.exports.monopattino = (req,res) => {
    if(checkVeicoliFields(req.body) && req.body.batteriaMassima !== undefined){
        res.json(updateSQL.monopattino(req.body));
    }
    else res.json(missingFields);
}
module.exports.bici = (req,res) => {
    if(checkVeicoliFields(req.body) && req.body.casco !== undefined){
        res.json(updateSQL.bici(req.body));
    }
    else res.json(missingFields);
}
module.exports.ebike = (req,res) => {
    if(checkVeicoliFields(req.body) && req.body.casco !== undefined && req.body.caricaBatteria !== undefined){
        res.json(updateSQL.ebike(req.body));
    }
    else res.json(missingFields);
}
module.exports.utente = (req,res) => {

}


function checkVeicoliFields({ID,stato,disponibilita,latitudine,longitudine}){
    if(ID !== undefined && stato !== undefined && disponibilita !== undefined && latitudine !== undefined && longitudine !== undefined) return true;
    else return false;
}