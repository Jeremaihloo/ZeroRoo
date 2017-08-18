
function arrRemove (arr) {
  let what
  let a = arguments
  let L = a.length
  let ax
  while (L > 1 && arr.length) {
    what = a[--L]
    while ((ax = arr.indexOf(what)) !== -1) {
      arr.splice(ax, 1)
    }
  }
  return arr
}

export function clone (a) {
  return JSON.parse(JSON.stringify(a))
}

export function arrayRemove (arr, cb) {
  var targetArr = arr.filter(cb)
  arrRemove.apply(null, [arr].concat(targetArr))
}
