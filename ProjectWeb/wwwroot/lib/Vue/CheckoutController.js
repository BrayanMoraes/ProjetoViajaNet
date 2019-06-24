new Vue({
    el: '#app',
    data: {
        itemList: [],
        order: {
            ItemTypeId: 0,
            Quantity: 0,
            Confirmed: false
        }
    },
    methods: {
        sendBrowserInformation: function () {
            axios.get('/api/BrowserInformation/SaveInformations/landing')
                .then(x => {

                })
        },
        getItemTypeList: function () {
            axios.get('/api/ItemType/GetAllItemTypes')
                .then(x => {
                    console.log(x.data);
                    this.itemList = x.data;
                });
        },
        createOrder: function () {
            let itemTemp = this.order;
            console.log(itemTemp);
            axios.post('/api/Item/CreateItem/' + this.order.ItemTypeId + '/' + this.order.Quantity)
                .then(x => {
                    window.location.href = '/Home/ConfirmItem/' + x.data;
                });
        }
    },
    created() {
        this.sendBrowserInformation();
        this.getItemTypeList();
    }
});