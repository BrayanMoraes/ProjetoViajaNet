new Vue({
    el: '#app',
    data: {

    },
    methods: {
        sendBrowserInformation: function () {
            axios.get('/api/BrowserInformation/SaveInformations/home')
                .then(x => {

                })
        }
    },
    created() {
        this.sendBrowserInformation();
    }
});