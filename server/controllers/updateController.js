const DB = require('../db/dbconnection');
const updateSQL = require('../db/SQL/update');

const badQuery = {'error':'bad query'};
const noElements = {'error':'no elements'};
const missingFields = {'error':'missing fields'};
const goodQuery = {'good':'query succesfull'};

module.exports.motorinoelettrico = (req,res) => {
    if(checkVeicoliFields(req.body) && req.body.livelloBatteria !== undefined){
        //res.json(updateSQL.motorinoelettrico(req.body));
        [veicoliQuery,specificQuery] = updateSQL.motorinoelettrico(req.body).split(';');
        let IDquery = `SELECT * FROM motorinoelettrico WHERE ID=${req.body.ID};`;
        DB.query(IDquery,(err,result) => {
            if(err) res.json(badQuery);
            else if(result !== '[]'){
                DB.query(veicoliQuery);
                DB.query(specificQuery);
                res.json(goodQuery);
            }
            else res.json(noElements);
        });
    }
    else res.json(missingFields);
}
module.exports.auto = (req,res) => {
    if(checkVeicoliFields(req.body) && req.body.livelloBatteria !== undefined){
        [veicoliQuery,specificQuery] = updateSQL.auto(req.body).split(';');
        let IDquery = `SELECT * FROM auto WHERE ID=${req.body.ID};`;
        DB.query(IDquery,(err,result) => {
            if(err) res.json(badQuery);
            else if(result !== '[]'){
                DB.query(veicoliQuery);
                DB.query(specificQuery);
                res.json(goodQuery);
            }
            else res.json(noElements);
        });
    }
    else res.json(missingFields);
}
module.exports.monopattino = (req,res) => {
    if(checkVeicoliFields(req.body) && req.body.batteriaMassima !== undefined){
        [veicoliQuery,specificQuery] = updateSQL.monopattino(req.body).split(';');
        let IDquery = `SELECT * FROM monopattino WHERE ID=${req.body.ID};`;
        DB.query(IDquery,(err,result) => {
            if(err) res.json(badQuery);
            else if(result !== '[]'){
                DB.query(veicoliQuery);
                DB.query(specificQuery);
                res.json(goodQuery);
            }
            else res.json(noElements);
        });
    }
    else res.json(missingFields);
}
module.exports.bici = (req,res) => {
    if(checkVeicoliFields(req.body) && req.body.casco !== undefined){
        [veicoliQuery,specificQuery] = updateSQL.bici(req.body).split(';');
        let IDquery = `SELECT * FROM bici WHERE ID=${req.body.ID};`;
        DB.query(IDquery,(err,result) => {
            if(err) res.json(badQuery);
            else if(result !== '[]'){
                DB.query(veicoliQuery);
                DB.query(specificQuery);
                res.json(goodQuery);
            }
            else res.json(noElements);
        });
    }
    else res.json(missingFields);
}
module.exports.ebike = (req,res) => {
    if(checkVeicoliFields(req.body) && req.body.casco !== undefined && req.body.caricaBatteria !== undefined){
        [veicoliQuery,specificQuery] = updateSQL.ebike(req.body).split(';');
        let IDquery = `SELECT * FROM ebike WHERE ID=${req.body.ID};`;
        DB.query(IDquery,(err,result) => {
            if(err) res.json(badQuery);
            else if(result !== '[]'){
                DB.query(veicoliQuery);
                DB.query(specificQuery);
                res.json(goodQuery);
            }
            else res.json(noElements);
        });
    }
    else res.json(missingFields);
}
// module.exports.utente = (req,res) => {

// }

function checkVeicoliFields({ID,stato,disponibilita,latitudine,longitudine}){
    if(ID !== undefined && stato !== undefined && disponibilita !== undefined && latitudine !== undefined && longitudine !== undefined) return true;
    else return false;
}