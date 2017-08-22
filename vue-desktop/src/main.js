// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'

import 'bootstrap/dist/css/bootstrap.min.css'

import * as uiv from 'uiv'
import locale from 'uiv/src/locale/lang/zh-CN'
console.log('use', uiv, locale)
Vue.use(uiv, { locale })

require('normalize-css')

Vue.config.productionTip = false

import Engine from './engine'
Vue.use(Engine)

import EventBus from './eventbus'
Vue.use(EventBus)

/* eslint-disable no-new */
new Vue({
  el: '#app',
  template: '<App/>',
  components: { App }
})
