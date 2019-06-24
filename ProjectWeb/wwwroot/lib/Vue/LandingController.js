new Vue({
    el: '#app',
    data: {
        orderList: [],
        itemList: []
    },
    methods: {
        sendBrowserInformation: function () {
            axios.get('/api/BrowserInformation/SaveInformations/landing')
                .then(x => {

                })
        },
        getOrderList: function () {
            axios.get('/api/Item/GetAllItems')
                .then(x => {
                    console.log(x.data);
                    this.orderList = x.data;
                });
        },
        getItemTypeList: function () {
            axios.get('/api/ItemType/GetAllItemTypes')
                .then(x => {
                    console.log(x.data);
                    this.itemList = x.data;
                });
        }
    },
    created() {
        this.sendBrowserInformation();
        this.getItemTypeList();
        this.getOrderList();
    }
});