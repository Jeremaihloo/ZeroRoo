var $ = require('jquery')
export default class Event {
  on (name, cb) {
    $(document).on(name, function (e, data) {
      cb(data)
    })
  }

  emit (name, data) {
    $(document).trigger(name, data)
  }
}
