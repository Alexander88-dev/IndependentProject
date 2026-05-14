const products = {
    0: ['Салат', 'https://main-cdn.sbermegamarket.ru/big2/hlr-system/-71/586/489/107/102/4/100071138732b0.jpg',
        '200', 'огурец, помидор, оливковое масло, зелень, ккал 50.'],
    1: ['Картошка фри', 'https://avatars.mds.yandex.net/i?id=030f427a012113262d8699b20473ecb9_l-4237726-images-thumbs&n=13',
        '100', 'белорусская картошка, ккал 260.'],
    2: ['Наггетсы', 'https://avatars.mds.yandex.net/get-mpic/13326398/2a0000019a8be777a24427f8e7d53910c362/orig',
        '200', 'куриное филе, яйца, мука, соль, чёрный перец, ккал 273.'],
    3: ['Мягкое мороженое', 'https://main-cdn.sbermegamarket.ru/big1/hlr-system/111/118/259/412/016/3/100063978046b0.jpg',
        '100', 'сливки, сгущённое молоко, ккал 186.']
};
function togglePassword(inputId, button) {
    const input = document.getElementById("PasswordVisibilityI");
    //const label = document.getElementById("labelId");
    if (input.type === "password") {
        input.type = "text";
        //label.innerText = 'новый текст'
    }
    else {
        input.type = "password";
        //label.innerText = 'новый текст'
    }
}
$("Order").ready(function () {

    for (var i = 0; i < Object.keys(products).length; i++) {
        var card = document.createElement("div");
        card.classList.add("card"); card.classList.add("Card");
        //проблема с получением элемента суммы блюда
        card.innerHTML = `
                        <h3>   ${products[i][0]}</h3>
                        <img src="${products[i][1]}" alt="${products[i][0]}">
                        <p class="price" style="font-size: 140% id = "moneyId${[i]}">${products[i][2]}</p>
                        <p>${products[i][3]}</p>
                        <label>
                            Кол <input onchange = "OnChangeEvent()" type="number" value="1" min="1" max="100" name = "imputName" />
                        </label>
                        <br>
                        <p style="font-size: 120%" id = "sumId${[i]}">Общая сумма: 0 руб.</p>
                        <br>
                        <button>В корзину</button>
                        `;
        var container = document.getElementById("idCardContainer");
        container.appendChild(card);
    }
});

function OnChangeEvent() {
    for (var i = 0; i < Object.keys(products).length; i++) {
        console.log(Number(document.getElementById(`moneyId${[i]}`)));
       // document.getElementById(`sumId${[i]}`)[i].value = `Общая сумма: ${Number(document.getElementsByName("imputName")[i].value) * Number(document.getElementById(`moneyId${[i]}`).value)} руб.`;
    }

}

//document.querySelectorAll('inputNumber[type="number"]').addEventListener('inputNumber', () => console.log('Текущее значение:'));



//var inputCard = document.getElementsByClassName('inputNumber')
//document.addEventListener('keydown', (this) => {
//    this.preventDefault();
//});