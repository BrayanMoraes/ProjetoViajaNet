new Vue({
    el: '#app',
    data: {
    },
    methods: {
        sendBrowserInformation: function () {
            axios.get('/api/BrowserInformation/SaveInformations/landing')
                .then(x => {

                })
        },
        confirm: function (id) {
            axios.post('/api/Item/ConfirmItem/' + id)
                .then(x => {
                    alert('Confirmado com sucesso!')
                    window.location.href = '/Home/Index';
                });
        }
    },
    created() {
        this.sendBrowserInformation();
    }
});