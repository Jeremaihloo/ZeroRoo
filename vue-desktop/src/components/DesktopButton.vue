<template>
  <div class="file-item" :class="{
                                 selected:selected,
                                 dragging:dragging
                                 }">
    <div class="file-body" @mousedown="onMouseDown">
      <div class="icon" :style="{
                                   'background-image':'url(http://localhost:8000' + icon + ')'
                                   }">

      </div>
      <div class="text">
        {{file.Text}}
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: ['file', 'dragging', 'selected'],
  watch: {
    selected: {
      handler: function (val, oldVal) {
        console.log('change file', val, oldVal)
      },
      deep: true
    }
  },
  computed: {
    icon () {
      console.log('File Icon', this.file.MenuItem.Icon)
      return this.file.MenuItem.Icon.replace(/\\/g, '/')
    }
    // selected () {
    //   console.log('computed selected', this.file.selected)
    //   return this.file.selected
    // }
  },
  methods: {
    onMouseDown () {
      this.$emit('onMouseDown', this.file)
    }
  }
}
</script>

<style lang="less" scoped>
.file-item {
  position: absolute;
  /*border:1px dashed #fff;*/
  &.selected {
    .file-body {
      /*border:2px solid rgba(43, 115, 199, 0.36);*/
      /*background:rgba(43, 115, 199, 0.2);*/
      background: rgba(0, 134, 255, 0.27);
    }
  }
  &.dragging {
    opacity: 0.6;
  }
  .file-body {
    /*border:2px solid transparent;*/
    border-radius: 4px;
    // position: absolute;
    top: 50%;
    left: 50%;
    width: 90px;
    .icon {
      height: 80px;
      width: 80%;
      margin: 0 auto;
      background-size: 64px;
      background-repeat: no-repeat;
    }
    .text {
      min-height: 20px;
      line-height: 20px;
      text-align: center;
      /*margin:0 -10px; */
      overflow: hidden;
      word-wrap: break-word;
      word-break: break-all;
      text-overflow: ellipsis;
      padding-bottom: 5px;
    }
  }
}
</style>


