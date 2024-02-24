console.log('acabou o tempo')

function isNumber(evt) {
    evt = (evt) ? evt : window.event
    let charCode = (evt.wich) ? evt.wich : evt.keyCode

    if (charCode > 31 && (charCode < 48 || charCode > 57)) return false

    return true
}