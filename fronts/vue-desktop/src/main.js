// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'

import 'bootstrap/dist/css/bootstrap.min.css'

import * as uiv from 'uiv'
import locale from 'uiv/src/locale/lang/zh-CN'
Vue.use(uiv, { locale })

require('normalize-css')

Vue.config.productionTip = false

import Engine from 'zeroroo-desktop'
console.log(Engine)
Vue.use(Engine)

import VueRouter from 'vue-router'
Vue.use(VueRouter)

/* eslint-disable no-new */
new Vue({
  el: '#app',
  template: '<App/>',
  components: { App }
})
