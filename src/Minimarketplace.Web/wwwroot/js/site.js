const DEFAULT = {
    products: [
        {id:'p1',title:'Ароматная свеча "Лаванда"',price:'15€',desc:'Ручная работа, натуральный воск',img:'https://images.unsplash.com/photo-1616627893020-03c569d1c1f3?q=80&w=600'},
        {id:'p2',title:'Свеча "Ваниль"',price:'18€',desc:'Согревающий аромат',img:'https://images.unsplash.com/photo-1616627893019-03c569d1c1f3?q=80&w=600'},
        {id:'p3',title:'Свеча "Корица"',price:'20€',desc:'Пряный аромат для уюта',img:'https://images.unsplash.com/photo-1616627893018-03c569d1c1f3?q=80&w=600'}
    ]
};

const $ = id => document.getElementById(id)

function navigateTo(id){
    document.querySelectorAll('.page').forEach(p=>p.classList.remove('active'))
    const el = $(id); if(el) el.classList.add('active')
    window.scrollTo({top:0,behavior:'smooth'})
}

window.navigateTo = navigateTo

// populate products
function renderProducts(){
    const list = $('#productsList')
    const grid = $('#productsGrid')
    list.innerHTML = ''
    grid.innerHTML = ''
    DEFAULT.products.forEach(p=>{
        const div = document.createElement('div')
        div.className='service'
        div.innerHTML=`<h4>${p.title}</h4><div class="note">${p.desc}</div><div class="price">${p.price}</div>`
        list.appendChild(div)
        const div2 = div.cloneNode(true)
        grid.appendChild(div2
