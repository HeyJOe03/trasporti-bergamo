const insertSQL = require('../db/SQL/insert');
const DB = require('../db/dbconnection');

const MissingFields = {'error':'missing fields'};
const Omonimi = {"error":"account already used"};
const queryError = {"error":"query error"}
const errorsMessage = {'message':'errors'};
const goodState = {'message':'good state'};

module.exports.motorinoelettrico = (req,res) => {
    let sql = insertSQL.motorinoElettrico(req.body);

    if(sql === '') {res.json(MissingFields); return}

    //if(verifyIDveicoli(req.body.ID)) {res.json(Omonimi); return;}

    let [sqlA,sqlB] = sql.split(';');


    DB.query(`SELECT ID FROM veicoli WHERE ID = ${req.body.ID};`, (err, result) => {
        if (err)
            return true;
        if (JSON.stringify(result) !== JSON.stringify([])) res.json(Omonimi);
        else{
            let er = false;
            DB.query(sqlA, (err) => {
                if (err) {res.json(queryError);er = true}
            });
            if(er) return;
            DB.query(sqlB, (err) => {
                if (err) {res.json(queryError);er = true}
            });
            //if(er) res.json(errorsMessage);
            if(!er) res.status(200).json(goodState);
        }
    });

}
module.exports.auto = (req,res) => {
    let sql = insertSQL.auto(req.body);
    
    if(sql === '') {res.json(MissingFields); return}

    //if(verifyIDveicoli(req.body.ID)) {res.json(Omonimi); return;}

    let [sqlA,sqlB] = sql.split(';');

    DB.query(`SELECT ID FROM veicoli WHERE ID = ${req.body.ID};`, (err, result) => {
        if (err)
            return true;
        if (JSON.stringify(result) !== JSON.stringify([])) res.json(Omonimi);
        else{
            let er = false;
            DB.query(sqlA, (err) => {
                if (err) {res.json(queryError);er = true}
            });
            if(er) return;
            DB.query(sqlB, (err) => {
                if (err) {res.json(queryError);er = true}
            });
            //if(er) res.json(errorsMessage);
            if(!er) res.status(200).json(goodState);
        }
    });

}
module.exports.bici = (req,res) => {
    let sql = insertSQL.bici(req.body);
    
    if(sql === '') {
        res.json(MissingFields); 
        return;
    }

    DB.query(`SELECT ID FROM veicoli WHERE ID = ${req.body.ID};`, (err, result) => {
        if (err)
            return true;
        if (JSON.stringify(result) !== JSON.stringify([])) res.json(Omonimi);
        else{
            let [sqlA,sqlB] = sql.split(';');

            let er = false;
            DB.query(sqlA, (err) => {
                if (err) {res.json(queryError);er = true;}
            });
            if(er) return;
            DB.query(sqlB, (err) => {
                if (err) {res.json(queryError);er = true;}
            });

            //if(er) res.json(errorsMessage);
            if(!er) res.status(200).json(goodState);
        }
    });
    
}
module.exports.ebike = (req,res) => {
    let sql = insertSQL.ebike(req.body);
    if(sql === '') {res.json(MissingFields); return}

    //if(verifyIDveicoli(req.body.ID)) {res.json(Omonimi); return;}

    let [sqlA,sqlB,sqlC] = sql.split(';');


    DB.query(`SELECT ID FROM veicoli WHERE ID = ${req.body.ID};`, (err, result) => {
        if (err)
            return true;
        if (JSON.stringify(result) !== JSON.stringify([])) res.json(Omonimi);
        else{
            let er = false;
            DB.query(sqlA, (err) => {
                if (err) {res.json(queryError);er = true}
            });
            if(er) return;
            DB.query(sqlB, (err) => {
                if (err) {res.json(queryError);er = true}
            });
            if(er) return;
            DB.query(sqlC, (err) => {
                if (err) {res.json(queryError);er = true}
            });
            //if(er) res.json(errorsMessage);
            if(!er) res.status(200).json(goodState);
        }
    });
    
}
module.exports.monopattinoelettrico = (req,res) => {
    let sql = insertSQL.monopattino(req.body);
    if(sql === '') {res.json(MissingFields); return}

    //if(verifyIDveicoli(req.body.ID)) {res.json(Omonimi); return;}

    let [sqlA,sqlB] = sql.split(';');

    DB.query(`SELECT ID FROM veicoli WHERE ID = ${req.body.ID};`, (err, result) => {
        if (err)
            return true;
        if (JSON.stringify(result) !== JSON.stringify([])) res.json(Omonimi);
        else{
            let er = false;
            DB.query(sqlA, (err) => {
                if (err) {res.json(queryError);er = true}
            });
            if(er)return;
            DB.query(sqlB, (err) => {
                if (err) {res.json(queryError);er = true}
            });
            
            //if(er) res.json(errorsMessage);
            if(!er) res.status(200).json(goodState);
        }
    });
}
module.exports.utente = (req,res) => {

    let sql = insertSQL.utente(req.body);
    if(sql === '') {res.json(MissingFields); return}

    DB.query(`SELECT CF FROM utenti WHERE CF = '${req.body.CF}';`, (err,result) => {
        if (err) return false;
        if (JSON.stringify(result) !== JSON.stringify([])) res.json(Omonimi); // se ci sono degli omonimi
        else{
            DB.query(sql, (err) => {
                if (err){ res.json(queryError);err.message();}
                else res.status(200).json(goodState);
            });
        }
    });
}