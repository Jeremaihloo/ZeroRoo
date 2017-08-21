
import Vue from 'vue'

class EventBus {
  constructor () {
    this.vueObj = new Vue()
  }

  on (event, callback) {
    this.vueObj.$on(event, callback)
  }

  emit (event, args) {
    this.vueObj.$emit(event, args)
  }

  install (Vue, options) {
    Vue.prototype.$bus = this
  }
}

export default new EventBus()
