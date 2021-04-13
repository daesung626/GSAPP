const pwdInput = document.getElementById('password');
const show = document.getElementById('show-pwd');

const mobileDashNav = document.querySelector('.mobile-dashNav');
const dashNavBtn = document.getElementById('dash-btn');

const mobileNav = document.querySelector('.mobile-nav');
const navBtn = document.getElementById('nav-btn');

const menuIcon = document.getElementById('menu-icon');

function showPwd() {
    if (pwdInput.type === 'password'){
        show.innerHTML = '<i class="far fa-eye-slash"></i>';
        pwdInput.type = 'text';
    } else{
        show.innerHTML = '<i class="far fa-eye"></i>';
        pwdInput.type = 'password';
    }
}

navBtn.addEventListener('click', landingNav);
dashNavBtn.addEventListener('click', dashNav);

function landingNav(){
    console.log('clicked');
    menuIcon.classList.toggle('animate')
    mobileNav.classList.toggle('show');
}

function dashNav(){
    console.log('clicked dash');
    menuIcon.classList.toggle('animate')
    mobileDashNav.classList.toggle('show');
}


window.onload = function () {
    getCovidStats();
}

function getCovidStats(){
    fetch('https://coronavirus-tracker-api.herokuapp.com/v2/locations/225')
    .then(function (resp) { return resp.json() })
    .then(function (data) {
        let update = data.location.last_updated;
        let confirmedCases = data.location.latest.confirmed;
        let deaths = data.location.latest.deaths;
        document.getElementById('update').innerHTML = update.substr(0, 10);
        document.getElementById('cases').innerHTML = confirmedCases.toLocaleString('en');
        document.getElementById('deaths').innerHTML = deaths.toLocaleString('en');
        document.getElementById('percent').innerHTML = ((Number(deaths) / Number(confirmedCases)) * 100).toLocaleString("en", { minimumFractionDigits: 2, maximumFractionDigits: 2 }) + "%";
    })
    .catch(function () {
        console.log("error");
    })
    setTimeout(getCovidStats, 86400000) // update every 24 hours
}