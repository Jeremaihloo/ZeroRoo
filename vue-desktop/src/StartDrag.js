// by zhangxinxu welcome to visit my personal website http://www.zhangxinxu.com/
// zxx.drag v1.0 2010-03-23

var getCss = function (o, key) {
  return o.currentStyle ? o.currentStyle[key] : document.defaultView.getComputedStyle(o, false)[key]
}

var StartDrag = function (bar, target, callback) {
  let params = {
    left: 0,
    top: 0,
    currentX: 0,
    currentY: 0,
    flag: false
  }

  if (getCss(target, 'left') !== 'auto') {
    params.left = getCss(target, 'left')
  }
  if (getCss(target, 'top') !== 'auto') {
    params.top = getCss(target, 'top')
  }
  bar.onmousedown = function (event) {
    console.log('dragbar, onmousedown')
    params.flag = true
    if (!event) {
      event = window.event
      bar.onselectstart = function () {
        return false
      }
    }
    let e = event
    params.currentX = e.clientX
    params.currentY = e.clientY
  }
  document.onmouseup = function () {
    params.flag = false
    if (getCss(target, 'left') !== 'auto') {
      params.left = getCss(target, 'left')
    }
    if (getCss(target, 'top') !== 'auto') {
      params.top = getCss(target, 'top')
    }
  }
  document.onmousemove = function (eventa) {
    let e = event ? eventa : window.event
    let disX
    let disY
    if (params.flag) {
      let nowX = e.clientX
      let nowY = e.clientY
      disX = nowX - params.currentX
      disY = nowY - params.currentY
      target.style.left = parseInt(params.left) + disX + 'px'
      target.style.top = parseInt(params.top) + disY + 'px'
      if (event.preventDefault) {
        event.preventDefault()
      }
      return false
    }

    if (typeof callback === 'function') {
      callback(parseInt(params.left) + disX, parseInt(params.top) + disY)
    }
  }
}

export default StartDrag
