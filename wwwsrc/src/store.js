import Vue from "vue";
import Vuex from "vuex";
import Axios from "axios";
import router from "./router";

Vue.use(Vuex);

let baseUrl = location.host.includes("localhost") ? "//localhost:5000/" : "/";

let api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 3000,
  withCredentials: true
});

export default new Vuex.Store({
  state: {
    user: {}
  },
  mutations: {
    setUser(state, user) {
      state.user = user;
    },
    resetState(state) {
      //clear the entire state object of user data
      state.user = {};
    }
  },
  actions: {}
});
