<template>
  <div id="applications">

    <section>
      <ul class="nav nav-tabs" role="tablist">
        <template v-for="(tab, index) in activities">
          <li role="presentation" :class="{'active':tab.Active}" :key="index">
            <a role="tab" href="javascript:void(0);" @click="select(activities.indexOf(tab))">
              <span v-text="tab.Title"></span>
            </a>
          </li>
        </template>
        <li class="pull-right">
          <button type="button" class="btn btn-success">关闭</button>
        </li>
      </ul>
      <div class="tab-content">
        <div class="tab-pane" role="tabpanel" v-for="(tab, index) in activities" :class="{active:tab.Active}" :key="index" v-show="tab.Active">
          <app-activity class="app-activity" :activity="tab"></app-activity>
        </div>
      </div>
    </section>

  </div>
</template>

<script>
import AppActivity from './AppActivity'
import Draggable from 'vuedraggable'
// import StartDrag from '../StartDrag'

export default {
  components: {
    AppActivity,
    Draggable
  },
  data () {
    return {
      activities: [],
      drag: false,
      activeIndex: 0
    }
  },
  watch: {
    activeIndex: function (val, oldVal) {
      console.log('tabIndex changed', val, oldVal)
    }
  },
  created () {
    if (this.activities.length === 0) {
      let welcome = {
        Title: '欢迎',
        HtmlUri: 'http://wwww.baidu.com'
      }
      this.activities.push(welcome)
      this.select(this.activities.length - 1)
    }
    this.$bus.on('activity:open', activity => {
      activity.Active = false
      activity.Title = 'Empty Title'
      console.log(this.activities, activity)
      var find = this.activities.filter(item => {
        return item.HtmlUri === activity.HtmlUri
      })
      console.log('find', find)
      if (find.length === 0) {
        this.activities.push(activity)
        console.log('activity:open callback', activity)
        this.select(this.activities.length - 1)
      }
    })
  },
  mounted () {

  },
  methods: {
    selectCurrent () {
      this.activities.forEach(tab => {
        tab.Active = false
      })
      let tab = this.activities[this.activeIndex]
      tab.Active = true
      console.log('selectCurrent tab', tab)
    },
    select (index) {
      console.log('onSelect', index)
      this.activeIndex = index
      this.selectCurrent()
    }
  }
}
</script>

<style lang="stylus" scoped>
</style>

