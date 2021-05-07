function checkVeicolo (obj) {
    let {ID,marca,stato,disponibilita,posti,latitudine,longitudine,costoMinuto,costoOra,costoGiorno} = obj;
    if (ID ===undefined || marca ===undefined || stato ===undefined || disponibilita ===undefined || posti ===undefined || latitudine ===undefined || longitudine ===undefined || costoMinuto ===undefined || costoOra ===undefined || costoGiorno) return true;
    else return false;
}



module.exports.veicoli = ({ID,marca,stato,disponibilita,posti,latitudine,longitudine,costoMinuto,costoOra,costoGiorno}) => {
   
   let sql = `INSERT INTO veicoli (ID,marca,stato,disponibilita,posti,latitudine,longitudine,costoMinuto,costoOra,costoGiorno) VALUES (${ID},'${marca}',${stato},${disponibilita},${posti},${latitudine},${longitudine},${costoMinuto},${costoOra},${costoGiorno});`
    return sql;
}

module.exports.auto = ({targa,livelloBatteria,...obj}) => {
    if(checkVeicolo(obj) == false) return '';
    if(undefined ===targa || undefined ===livelloBatteria) return ''; 

    let sql = this.veicoli(obj);
    sql += `
        INSERT INTO auto (ID,targa,livelloBatteria)
        VALUES (${obj.ID},'${targa}',${livelloBatteria});
    `;

    return sql
}

module.exports.bici = ({tipologia,dimensione,seggiolino,casco,costoSblocco,...obj}) => {
    if(checkVeicolo(obj) == false) return '';
    if(undefined ===tipologia || undefined ===dimensione || undefined ===seggiolino || undefined ===casco || undefined ===costoSblocco) return '';
    let sql = this.veicoli(obj);
    sql += `INSERT INTO bici (ID,tipologia,dimensione,seggiolino,casco,costoSblocco)
            VALUES (${obj.ID},'${tipologia}','${dimensione}',${seggiolino},${casco},${costoSblocco});`
    
    return sql;
}

module.exports.ebike = ({caricaBatteria,...obj}) => {
    if(undefined ===caricaBatteria) return '';

    let sql = this.bici(obj);

    if(sql === '') return '';

    sql += `
        INSERT INTO ebike (ID,caricaBatteria)
        VALUES (${obj.ID},${caricaBatteria});
    `;

    return sql;
}

module.exports.monopattino = ({batteriaMassima,segnaleAcustico,...obj}) => {
    if(checkVeicolo(obj) == false) return '';
    if(undefined ===batteriaMassima || undefined ===segnaleAcustico) return '';

    let sql = this.veicoli(obj);

    sql += `
        INSERT INTO monopattino (ID,batteriaMassima,segnaleAcustico)
        VALUES (${obj.ID},${batteriaMassima},${segnaleAcustico});
    `;

    return sql;
}

module.exports.motorinoElettrico = ({targa,livelloBatteria,radio,...obj}) => {
    if(checkVeicolo(obj) == false) return '';
    if(undefined === targa || undefined === livelloBatteria || radio === undefined) return '';

    let sql = this.veicoli(obj);

    sql += `INSERT INTO motorinoelettrico (ID,targa,livelloBatteria,radio) VALUES (${obj.ID},'${targa}',${livelloBatteria},${radio});`;

    return sql;
}

module.exports.utente = ({CF,documento,giorno,mese,anno}) => {
    if(!(CF && documento && giorno && mese && anno)) return '';

    let sql = `
        INSERT INTO utenti (CF,documento,giorno,mese,anno)
        VALUES ('${CF}','${documento}',${giorno},${mese},${anno});
    `
    return sql;
}