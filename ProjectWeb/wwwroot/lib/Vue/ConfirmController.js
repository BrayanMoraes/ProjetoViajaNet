new Vue({
    el: '#app',
    data: {

    },
    methods: {
        sendBrowserInformation: function () {
            axios.get('/api/BrowserInformation/SaveInformations/confirm')
                .then(x => {

                })
        }
    },
    created() {
        this.sendBrowserInformation();
    }
});