module.exports.motorinoelettrico = ({livelloBatteria,...params}) => {
    let sql = veicoli(params);
    sql += `UPDATE motorinoelettrico SET livelloBatteria=${livelloBatteria} WHERE ID=${params.ID} ;`
    return sql;
}
module.exports.auto = ({livelloBatteria,...params}) => {
    let sql = veicoli(params);
    sql += `UPDATE auto SET livelloBatteria=${livelloBatteria} WHERE ID=${params.ID} ;`
    return sql;
}

module.exports.monopattino = ({batteriaMassima,...params}) => {
    let sql = veicoli(params);
    sql += `UPDATE monopattino SET batteriaMassima=${batteriaMassima} WHERE ID=${params.ID} ;`
    return sql;
}

module.exports.bici = ({...params}) => {
    let sql = veicoli(params);
    return sql;
}

module.exports.ebike = ({caricaBatteria,...params}) => {
    let sql = veicoli(params);
    sql += `UPDATE ebike SET caricaBatteria=${caricaBatteria} WHERE ID=${params.ID};`
    return sql;
}

module.exports.noleggia = ({ID}) => {
    return `UPDATE veicoli SET disponibilita = 1 WHERE ID = ${ID} ;`
}

module.exports.segnala = ({ID}) => {
    return `UPDATE veicoli SET disponibilita = 1,stato = 1 WHERE ID = ${ID} ;`
}


function veicoli({latitudine,longitudine,ID}){
    let s = `UPDATE veicoli SET disponibilita = 0,latitudine=${latitudine},longitudine=${longitudine} WHERE ID=${ID};`;
    return s;
}