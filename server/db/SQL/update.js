module.exports.motorinoelettrico = ({livelloBatteria,...params}) => {
    let sql = veicoli(params);
    sql += `UPDATE motorinoelettrico SET livelloBatteria=${livelloBatteria} WHERE ID=${params.ID} ;`
    return sql;
}
module.exports.auto = ({livelloBatteria,...params}) => {
    let sql = veicoli(params);
    sql += `UPDATE auto SET ivelloBatteria=${livelloBatteria} WHERE ID=${params.ID} ;`
    return sql;
}

module.exports.monopattino = ({batteriaMassima,...params}) => {
    let sql = veicoli(params);
    sql += `UPDATE monopattino SET batteriaMassima=${batteriaMassima} WHERE ID=${params.ID} ;`
    return sql;
}

module.exports.bici = ({casco,...params}) => {
    let sql = veicoli(params);
    sql += `UPDATE bici SET casco=${casco} WHERE ID=${params.ID} ;`
    return sql;
}

module.exports.ebike = ({caricaBatteria,casco,...params}) => {
    let sql = veicoli(params);
    sql += `UPDATE ebike SET caricaBatteria=${caricaBatteria},casco=${casco} WHERE ID=${params.ID};`
    return sql;
}

module.exports.utente = (params) => {
    
}


function veicoli({stato,disponibilita,latitudine,longitudine,ID}){
    let s = `UPDATE veicoli SET stato=${stato},disponibilita=${disponibilita},latitudine=${latitudine},longitudine=${longitudine} WHERE ID=${ID};`;
    return s;
}