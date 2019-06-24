new Vue({
    el: '#app',
    data: {

    },
    methods: {
        sendBrowserInformation: function () {
            axios.get('/api/BrowserInformation/SaveInformations/checkout')
                .then(x => {

                })
        }
    },
    created() {
        this.sendBrowserInformation();
    }
});