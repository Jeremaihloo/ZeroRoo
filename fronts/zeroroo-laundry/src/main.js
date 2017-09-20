// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router'

Vue.config.productionTip = false

import 'bootstrap/dist/css/bootstrap.min.css'

import * as uiv from 'uiv'
import locale from 'uiv/src/locale/lang/zh-CN'
Vue.use(uiv, { locale })

import VueFormGenerator from 'vue-form-generator'
Vue.use(VueFormGenerator)

import VfgFieldsForUiv from 'vfg-fields-for-uiv'
console.log(VfgFieldsForUiv)
Vue.use(VfgFieldsForUiv)

import Engine from 'zeroroo-desktop'
Vue.use(Engine)

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  template: '<App/>',
  components: { App }
})
