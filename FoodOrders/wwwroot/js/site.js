function addCard() {
    var card = document.createElement("div");
    card.classList.add("card Card");

    card.innerHTML = `
                <h3>Салат</h3>
            `;

    var container = document.getElementById("idCardContainer");
    container.appendChild(card);
}
/*
         <img src="https://main-cdn.sbermegamarket.ru/big2/hlr-system/-71/586/489/107/102/4/100071138732b0.jpg" alt="Салат">

                <p class="price" style="font-size: 140%">200 руб.</p>
                <p>огурец, помидор, оливковое масло, зелень, ккал 50.</p>
                <label>
                Кол <input class="inputNumber" type="number" value="1" min="1" max="100" />
                </label>
                <br>
                <p style="font-size: 120%">Общая сумма: 0 руб.</p>
                <br>
                <button>В корзину</button>
 */
function togglePassword(inputId, button)
{
    const input = document.getElementById("PasswordVisibilityI");
    //const label = document.getElementById("labelId");
     if (input.type === "password")
    {
        input.type = "text";
        //label.innerText = 'новый текст'
    }
    else
    {
        input.type = "password";
        //label.innerText = 'новый текст'
    }
}

//document.getElementsByClassName('inputNumber').document.addEventListener('keydown', (this) => {
//    this.preventDefault();
//});