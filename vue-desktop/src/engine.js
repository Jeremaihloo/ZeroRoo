
class Engine {
  constructor () {
    this.subscribes = {}
    this.beforeOpen = []
    this.Version = '0.0.1'

    this.ws = new WebSocket('ws://localhost:8000/apps')

    let _this = this
    this.ws.onopen = (ev) => {
      console.log('ONOPEN', ev)
      this.beforeOpen.forEach(function (msg) {
        console.log('SEND AFTER ONOPEN', msg)
        this.ws.send(JSON.stringify(msg))
      }, this)
    }

    this.ws.onmessage = (ev) => {
      console.log('ONMESSAGE', ev)
      let dataObj = JSON.parse(ev.data)
      let key = this.createSubscribeKey(dataObj)
      var callbacks = _this.subscribes[key]
      callbacks.forEach(function (callback) {
        callback(dataObj)
      }, this)
    }

    this.ws.onerror = (ev) => {
      console.log('ONERROR', ev)
      alert('系统出现异常，请退出！')
    }
  }

  subscribe (serviceName, action, callback) {
    let key = this.createSubscribeKey({
      ServiceName: serviceName,
      Action: action
    })
    if (this.subscribes[key] === undefined || this.subscribes[key] === null) {
      this.subscribes[key] = []
    }
    this.subscribes[key].push(callback)
  }

  call (msg, callback) {
    this.subscribe(msg.ServiceName, msg.Action, callback)
    if (this.ws.readyState === WebSocket.OPEN) {
      console.log('CALL', msg)
      this.ws.send(JSON.stringify(msg))
    } else {
      console.log('SAVE BEFORE OPENED', msg)
      this.beforeOpen.push(msg)
    }
  }

  createSubscribeKey (msg) {
    let path = msg.ServiceName + '.' + msg.Action
    path = path.replace(/\./g, '_')
    return path
  }

  messageAlert (msg, callback) {
    this.call(msg, res => {
      if (callback != null) {
        callback(res)
      }
    })
  }

  install (Vue, options) {
    // 1. 添加全局方法或属性
    Vue.prototype.$engine = this
  }
}

export default new Engine()
