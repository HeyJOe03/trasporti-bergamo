module.exports.motorinoelettrico = ({livelloBatteria,...params}) => {
    let sql = `UPDATE motorinoelettrico SET ${veicoli(params)},livelloBatteria=${livelloBatteria} WHERE ID=${params.ID} ;`
    return sql;
}
module.exports.auto = ({livelloBatteria,...params}) => {
    let sql = `UPDATE auto SET ${veicoli(params)},livelloBatteria=${livelloBatteria} WHERE ID=${params.ID} ;`
    return sql;
}

module.exports.monopattino = ({batteriaMassima,...params}) => {
    let sql = `UPDATE monopattino SET ${veicoli(params)},batteriaMassima=${batteriaMassima} WHERE ID=${params.ID} ;`
    return sql;
}

module.exports.bici = ({casco,...params}) => {
    let sql = `UPDATE bici SET ${veicoli(params)},casco=${casco} WHERE ID=${params.ID} ;`
    return sql;
}

module.exports.ebike = ({caricaBatteria,casco,...params}) => {
    let sql = `UPDATE ebike SET ${veicoli(params)},caricaBatteria=${caricaBatteria},casco=${casco} WHERE ID=${params.ID} ;`
    return sql;
}

module.exports.utente = (params) => {
    
}


function veicoli({stato,disponibilita,latitudine,longitudine}){
    let s = `stato='${stato}',disponibilita='${disponibilita}',latitudine='${latitudine}',longitudine='${longitudine}'`;
    return s;
}