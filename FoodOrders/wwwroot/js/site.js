var sizeProducts = 0;
var sum = 0;

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
jQuery(document).ready(function () {
    const products = {
        0: ['Салат', 'https://main-cdn.sbermegamarket.ru/big2/hlr-system/-71/586/489/107/102/4/100071138732b0.jpg',
            '200', 'огурец, помидор, оливковое масло, зелень, ккал 50.'],
        1: ['Картошка фри', 'https://avatars.mds.yandex.net/i?id=030f427a012113262d8699b20473ecb9_l-4237726-images-thumbs&n=13',
            '150', 'белорусская картошка, ккал 260.'],
        2: ['Наггетсы', 'https://avatars.mds.yandex.net/get-mpic/13326398/2a0000019a8be777a24427f8e7d53910c362/orig',
            '200', 'куриное филе, яйца, мука, соль, чёрный перец, ккал 273.'],
        3: ['Мягкое мороженое', 'https://main-cdn.sbermegamarket.ru/big1/hlr-system/111/118/259/412/016/3/100063978046b0.jpg',
            '100', 'сливки, сгущённое молоко, ккал 186.']
    };

    sizeProducts = Object.keys(products).length;

    for (var i = 0; i < sizeProducts; i++) {
        var card = document.createElement("div");
        card.classList.add("card"); card.classList.add("Card");
        card.innerHTML = `
                        <h3>   ${products[i][0]}</h3>
                        <img src="${products[i][1]}" alt="${products[i][0]}">
                        <p class="price" style="font-size: 140%" id = "moneyId${[i]}">${products[i][2]} руб.</p>
                        <p>${products[i][3]}</p>
                        <label>
                            Кол <input onchange = "OnChangeEvent()" type="number" value="1" min="1" max="100" id = "imputId${[i]}" />
                        </label>
                        <br>
                        <p style="font-size: 120%" id = "sumId${[i]}">Общая сумма: ${products[i][2]} руб.</p>
                        <br>
                        <button onclick = "AddToCart('${i}')" id = "basketId${[i]}">В корзину</button>
                        `;

        // Нужно исправить, try заглушка
        try {
            var container = document.getElementById("idCardContainer");
            container.appendChild(card);
        }
        catch (e) { }
    }
});

function OnChangeEvent() {
    for (var i = 0; i < sizeProducts; i++) {
        document.getElementById(`sumId${[i]}`).textContent =
            `Общая сумма: ${document.getElementById(`imputId${[i]}`).value *
            Number(document.getElementById(`moneyId${[i]}`).textContent.replace(/\D/g, ''))} руб.`;
    }
}
function AddToCart(id)
{
    sum += Number(document.getElementById(`sumId${[id]}`).textContent.replace(/\D/g, ''));
    document.getElementById(`basketId`).textContent = `Сумма заказа ${sum} руб.`;
}

function OrderClick()
{
    document.getElementById("hiddenText").value = document.getElementById(`basketId`).textContent.replace(/\D/g, '');
}




//var inputCard = document.getElementsByClassName('inputNumber')
//document.addEventListener('keydown', (this) => {
//    this.preventDefault();
//});