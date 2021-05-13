module.exports.motorinoelettrico = (params) => {
    if(params.ID) return `SELECT * FROM veicoli INNER JOIN motorinoelettrico ON veicoli.ID=motorinoelettrico.ID WHERE veicoli.ID=${params.ID};`;
    else return `SELECT * FROM veicoli INNER JOIN motorinoelettrico ON veicoli.ID=motorinoelettrico.ID;`;
}
module.exports.auto = (params) => {
    if(params.ID) return `SELECT * FROM veicoli INNER JOIN auto ON veicoli.ID=auto.ID WHERE veicoli.ID=${params.ID};`;
    else return `SELECT * FROM veicoli INNER JOIN auto ON veicoli.ID=auto.ID;`;
}
module.exports.monopattino = (params) => {
    if(params.ID) return `SELECT * FROM veicoli INNER JOIN monopattino ON veicoli.ID=monopattino.ID WHERE veicoli.ID=${params.ID};`;
    else return `SELECT * FROM veicoli INNER JOIN monopattino ON veicoli.ID=monopattino.ID;`;
}
module.exports.bici = (params) => {
    if(params.ID) return `SELECT * FROM veicoli INNER JOIN bici ON bici.ID=auto.ID WHERE veicoli.ID=${params.ID};`;
    else return `SELECT * FROM veicoli INNER JOIN bici ON veicoli.ID=bici.ID;`;
}
module.exports.ebike = (params) => {
    if(params.ID) return `SELECT * FROM veicoli INNER JOIN ebike ON veicoli.ID=ebike.ID INNER JOIN bici ON veicoli.ID = bici.ID WHERE veicoli.ID=${params.ID};`;
    else return `SELECT * FROM veicoli INNER JOIN ebike ON veicoli.ID=ebike.ID INNER JOIN bici ON veicoli.ID = bici.ID;`;
}
module.exports.utente = (params) => {
    if(params.CF) return `SELECT * FROM utenti WHERE utenti.CF='${params.CF}';`;
    else return `SELECT * FROM utenti;`;
}