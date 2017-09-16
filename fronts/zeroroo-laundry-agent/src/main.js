// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'

import 'bootstrap/dist/css/bootstrap.min.css'

Vue.config.productionTip = false

import Vuetable from 'vuetable-2'
Vue.use(Vuetable)

import * as uiv from 'uiv'
import locale from 'uiv/src/locale/lang/zh-CN'

Vue.use(uiv, { locale })

import Engine from 'zeroroo-desktop'
Vue.use(Engine)

/* eslint-disable no-new */
new Vue({
  el: '#app',
  template: '<App/>',
  components: { App }
})
