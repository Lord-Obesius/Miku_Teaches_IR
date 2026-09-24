window.irStudy = {
    save: function (key, value) {
        localStorage.setItem(key, value);
    },

    load: function (key) {
        return localStorage.getItem(key);
    },

    clear: function (key) {
        localStorage.removeItem(key);
    }
};