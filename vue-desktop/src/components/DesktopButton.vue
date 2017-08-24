<template>
  <div class="desktop-item" :class="{
                                   selected:selected,
                                   dragging:dragging
                                   }">
    <div class="item-body" @mousedown="onMouseDown" @dblclick="onDbClick">
      <div class="icon" :style="{
                                     'background-image':'url(' + icon + ')'
                                     }">

      </div>
      <div class="text">
        {{item.Text}}
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: ['item', 'dragging', 'selected'],
  computed: {
    icon () {
      console.log('item Icon', this.item.Icon)
      return this.item.Icon.replace(/\\/g, '/')
    }
  },
  methods: {
    onMouseDown () {
      this.$emit('onMouseDown', this.item)
    },
    onDbClick () {
      this.$emit('onDbClick', this.item)
    }
  }
}
</script>

<style lang="less" scoped>
.desktop-item {
  // position: absolute;
  /*border:1px dashed #fff;*/
  margin-top: 5px;
  margin-left: 5px;
  &.selected {
    .item-body {
      /*border:2px solid rgba(43, 115, 199, 0.36);*/
      /*background:rgba(43, 115, 199, 0.2);*/
      background: rgba(0, 134, 255, 0.27);
    }
  }
  &.dragging {
    opacity: 0.6;
  }
  .item-body {
    /*border:2px solid transparent;*/
    border-radius: 4px; // position: absolute;
    top: 50%;
    left: 50%;
    width: 90px;
    .icon {
      height: 80px;
      width: 64px;
      margin: 0 auto;
      background-size: 64px;
      background-repeat: no-repeat;
      background-position-y: 8px;
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
      cursor: default;
    }
  }
}
</style>


