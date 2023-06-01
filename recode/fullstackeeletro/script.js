function exibirCategoria(categoria) { //mostra a quantidade
    let elementos = document.getElementsByClassName('box_produtos')
    for (let i = 0;i < elementos.length; i++){
        console.log(elementos[i].id)
        if (categoria == elementos[i].id){ //mostrar somente items escolhidos
            elementos[i].style = "display:inline-block"
        } else {
            elementos[i].style = "display:none"
        }
    }
}

let exibir_todos = () => {
    let elementos = document.getElementsByClassName('box_produtos')
    for (let i = 0; i < elementos.length; i++)
        elementos[i].style = "display:inline-block"
}

function menu() {
    let ham = document.getElementById('menu')
    if (ham.style.display == "none"){
        ham.style.display = "block"
    } else {
        ham.style.display = "none"
    }
}